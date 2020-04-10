using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Flores
{
    public class clsDireccion
    {
        public string calle { get; set; }
        public int numero { get; set; }
        public string codigoPostal { get; set; }
        public string localidad { get; set; }
        public string provincia { get; set; }
    }

    public class clsContacto
    {
        public string email { get; set; }
        public string telefono { get; set; }
    }

    public class clsAcceso
    {
        public int legajo { get; set; }
        public string clave { get; set; }
    }

    public class clsAviso
    {
        public clsCasilla casilla { get; set; }
        public string mensaje { get; set; }
    }

    public class clsCasilla
    {
        public List<string> mensajesRecibidos;
        public List<string> mensajesEnviados;
    }

    public class clsInscripcion
    {
        public bool habilitado { get; set; }
        public clsMateria materia { get; set; }
    }

    public class clsPersona
    {
        public string nombre { get; set; }
        public int dni { get; set; }
        public char sexo { get; set; }
        public DateTime fechaNac { get; set; }
        public clsContacto contacto { get; set; }
        public clsDireccion direccion { get; set; }
    }

    public class clsDocente : clsPersona
    {
        public clsAcceso acceso { get; set; }
        public clsAviso aviso { get; set; }
    }

    public class clsAyudante : clsPersona
    {
        public clsAcceso acceso { get; set; }
        public clsAviso aviso { get; set; }
    }

    public class clsAlumno : clsPersona
    {
        public clsAcceso acceso { get; set; }
        public clsAviso aviso { get; set; }
        public clsInscripcion inscripcion { get; set; }
        public List<clsMateria> materias;
    }

    public class clsFacultad
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public clsDireccion direccion { get; set; }
        public List<clsCarrera> carreras;
    }

    public class clsCarrera
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public clsPlan plan { get; set; }
    }

    public class clsPlan
    {
        public int id { get; set; }
        public int duracion { get; set; }
        public List<clsMateria> materias;
    }

    public class clsMateria
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public List<clsComision> comisiones;
        public bool regularizo { get; set; }
        public List<clsFinal> finales;
    }

    public class clsComision
    {
        public int id { get; set; }
        public string turno { get; set; }
        public clsAula aula { get; set; }
        public List<clsDocente> docentes;
        public List<clsAyudante> ayudantes;
        public List<clsAlumno> alumnos;
        public List<clsParcial> parciales;
    }

    public class clsParcial
    {
        public string tipo { get; set; }
        public int nota { get; set; }
    }
    
    public class clsFinal
    {
        public DateTime fecha { get; set; }
        public int nota { get; set; }
    }
    
    public class clsAula
    {
        public string nombre { get; set; }
        public int capacidad { get; set; }
    }

}
