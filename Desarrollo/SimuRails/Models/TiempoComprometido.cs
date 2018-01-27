﻿using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SimuRails.Resources;
using System.ComponentModel;

namespace SimuRails.Models
{
    public class TiempoComprometido : IMetodoSimulacion
    {
        private readonly ILog log = LogManager.GetLogger("");
        private Traza Traza;
        private long TiempoFinal;

        public TiempoComprometido() { }

        public bool EjecutarSimulacion(Traza traza, long tiempoFinal, BackgroundWorker backgroundWorker)
        {
            Traza = traza;
            TiempoFinal = tiempoFinal;

            // Inicializa la traza configurando y creando los objetos dinámicos que no se traen de la base
            Traza.Inicializar();

            long t = 0;

            // A partir del tiempo t, la traza le devuelve la instancia de formacion que tiene el horario de salida mas proximo.
            Formacion formacion = traza.GetProximaFormacion(t);

            t = formacion.HoraSalida;

            while (t < tiempoFinal)
            {
                long tiempoDeLaFormacion;

                Servicio servicio = formacion.Servicio;

                this.log.Info("Horarios disponibles de formaciones: \n"  + LogHelper.MostrarTiemposDeSalida(traza));
                this.log.Info("Horarios de programaciones: \n" + LogHelper.MostrarProgramaciones(traza));
                string programacionCorrespondiente = formacion.EstacionActual.EsEstacionTerminal? "Programación " + LogHelper.TimeConvert(formacion.ProgramacionCorrespondiente, false) : "Sin Programación";
                this.log.Info("T: " + LogHelper.TimeConvert(t,true) + " | Servicio: " + formacion.Servicio.Nombre + " | Formacion: "+ formacion.Nombre + ":" + formacion.Id + " | " + programacionCorrespondiente);


                // Calcular ingreso de pasajeros en estación Cabecera Inicial o Final del recorrido.
                tiempoDeLaFormacion = formacion.InicioRecorrido(t);

                //Calculo viaje hasta que llegue a destino, ya sea estacion Final o Mantenimiento.
                while (formacion.EstacionActual != formacion.EstacionDestino && !formacion.PasoPorMantenimiento)
                {
                    //Obtengo el camino a recorrer hasta la próxima estación.
                    //Debe poder obtener el tramo comprendido entre la estacionActual y la estacionSiguiente 
                    //en el sentido desde estacionActual -> formacion.getEstacionDestino()
                    Tramo tramo = servicio.GetTramo(formacion.EstacionActual, formacion.SentidoActual);
                    
                    //Realizo todos los calculos de entre estacion 1 y estacion 2
                    tiempoDeLaFormacion = formacion.ArriboEstacion(tramo, tiempoDeLaFormacion);

                }
                formacion.PasoPorMantenimiento = false;
                if (formacion.InvertirSentidoFlag) formacion.InvertirSentido();

                // Calcular ingreso de pasajeros en estación Cabecera Final del recorrido.
                // Cambiar el sentido de circulacion de la formacion formacion.invertirSentido();

                formacion = traza.GetProximaFormacion(t);

                t = formacion.HoraSalida;

                backgroundWorker.ReportProgress((int)(t*100/tiempoFinal));
                if (backgroundWorker.CancellationPending)
                {
                    return false;
                }

            }

            return true;

        }

    }

}