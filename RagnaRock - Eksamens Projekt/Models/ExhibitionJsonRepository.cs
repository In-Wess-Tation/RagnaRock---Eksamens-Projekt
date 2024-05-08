﻿using RagnaRock___Eksamens_Projekt.Pages;
using System.Formats.Asn1;

namespace RagnaRock___Eksamens_Projekt.Models
{
    public class ExhibitionJsonRepository : IExhibitionRepository
    {
        List<Exhibition> exhibitions;

        string path = @"C:\Users\Cupcake\OneDrive\Skrivebord\School\repos\RagnaRock - Eksamens Projekt\RagnaRock - Eksamens Projekt\Program.cs";
        public ExhibitionJsonRepository()
        {
            exhibitions = JsonReader.ReadFromFile(path);
        }

        //        public List<Animal> Animals { get => _animals; set => _animals = value; }

        public List<Exhibition> GetAll()
        {
            return exhibitions;
        }

        public void Add(Exhibition e)
        {
            if (exhibitions != null)
            {
                exhibitions.Add(e);
            }
        }

        public Exhibition Get(int id)
        {
            if (exhibitions != null)
                return (exhibitions[exhibitions.FindIndex(e => e.Id == id)]);
            return null;
        }

        public void Delete(int id)
        {
            //Vi tjekker lige at listen ikke er null eller tom - alternativt ville der blive smidt en exception
            if ((exhibitions != null) && (exhibitions.Count > 0))
            {
                //Her leder vi efter elementet gennem linq
                int c = exhibitions.FindIndex(e => e.Id == id);
                exhibitions.RemoveAt(exhibitions.FindIndex(e => e.Id == id));
                JsonWriter.WriteToFile(path, exhibitions);
            }
        }


    }
}