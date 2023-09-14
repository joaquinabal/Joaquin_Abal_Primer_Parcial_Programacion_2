﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class BaseDatosCursos
    {
        //Lista que contiene todos los cursos
        private List<Curso> _listaCursos = new List<Curso>();

        //Cursos por defecto
        private static Curso _cursoPorDefecto1 = new Curso("Programacion I", "Prog1", "1° año programacion", 150);
        private static Curso _cursoPorDefecto2 = new Curso("Ingles I", "Ing1", "1° año ingles", 80);
        private static Curso _cursoPorDefecto3 = new Curso("Matematica", "Mat1", "1° año matematica", 85);

        public BaseDatosCursos() 
        {
            //Ingreso los cursos por defecto a la base de datos
            IngresarCursoBD(_cursoPorDefecto1);
            IngresarCursoBD(_cursoPorDefecto2);
            IngresarCursoBD(_cursoPorDefecto3);
        }

        public void IngresarCursoBD(Curso nuevoCurso)
        {
            _listaCursos.Add(nuevoCurso);
        }

        public List<Curso> Cursos
        {
            get
            {
                return _listaCursos;
            }
        }
    }
}