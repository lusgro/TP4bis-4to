namespace TP4_Bis.Models;

public static class Info
{
    private static List<Pais> listaPaises;

    private static void IniciarLista()
    {
        listaPaises = new List<Pais>();
        listaPaises.Add(new Pais("Argentina", "banderaArgentina.png", "himnoArgentina.mp3", 45, new DateTime(1816, 7, 9), "El Glaciar Perito Moreno, La Ciudad de Buenos Aires y La Patagonia."));
        listaPaises.Add(new Pais("Mexico", "banderaMexico.png", "himnoMexico.mp3", 126, new DateTime(1810, 9, 16), "Chichén Itzá, Cancún y La Catedral Metropolitana."));
        listaPaises.Add(new Pais("Brasil", "banderaBrasil.png", "himnoBrasil.mp3", 213, new DateTime(1822, 9, 7), "El Cristo Redentor, Copacabana y Pan de Azúcar."));
        listaPaises.Add(new Pais("Sudafrica", "banderaSudafrica.png", "himnoSudafrica.mp3", 60, new DateTime(1910, 5, 31), "El Parque Nacional Kruger, Montaña de la Mesa y La Ruta Jardín."));
        listaPaises.Add(new Pais("Australia", "banderaAustralia.png", "himnoAustralia.mp3", 25, new DateTime(1901, 1, 1), "La Gran Barrera de Coral, El icónico Ópera de Sídney y El Parque Nacional de Uluru-Kata Tjuta"));
    }
    public static List<Pais> ListarPaises()
    {
        if (listaPaises == null)
        {
            IniciarLista();
        }
        return listaPaises;
    }
    public static Pais DetallePais(int id)
    {
        List<Pais> listaPaises = ListarPaises();
        Pais pais = listaPaises.Find(p => p.id == id);
        if (pais == null) return null;
        else return pais;
    }
}