namespace TP4_Bis.Models
{
    public class Pais
    {
        private static int idPais = 0;

        public int id{get; private set;}
        public string nombre{get; private set;}
        public string imgBandera{get; private set;}
        public string audioHimno{get; private set;}
        public int poblacion{get; private set;}
        public DateTime fechaIndependencia{get; private set;}
        public string atractivosTuristicos{get; private set;}
        
        public Pais(string nombre, string imgBandera, string audioHimno, int poblacion, DateTime fechaIndependencia, string atractivosTuristicos)
        {
            this.id = idPais++;
            this.nombre = nombre;
            this.imgBandera = imgBandera;
            this.audioHimno = audioHimno;
            this.poblacion = poblacion;
            this.fechaIndependencia = fechaIndependencia;
            this.atractivosTuristicos = atractivosTuristicos;
        }
    }
}