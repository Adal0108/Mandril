using MandrilAPI.Models;


//hghftyfty

namespace MandrilAPI.Services

{
    public class MandrilDataStore
    {
        public List<Mandril> Mandriles { get; set; }

        public static MandrilDataStore Current { get; }  = new MandrilDataStore();

        public MandrilDataStore() {
            Mandriles = new List<Mandril>() {

            new Mandril()
            {
              Id=1,
              Nombre="MiniMandril",

              Apellido="Rodriguez",
              Habilidades=new List<Habilidad>()
              {
                  new Habilidad()
                  {
                      Id=1,
                      Nombre="Saltar",
                      Potencia=Habilidad.Epotencia.Moderado,

                  }

              }




            },
            new Mandril()
            {
                Id=2,
                Nombre="SuperMandril" ,
                Apellido="Fernandez" ,

                Habilidades=new List<Habilidad>()
              {
                  new Habilidad()
                  {
                      Id=1,
                      Nombre="Saltar",
                      Potencia=Habilidad.Epotencia.Moderado

                  }
            }





         },
            new Mandril()
            {
                Id=3,
                Nombre="MegaMandril" ,
                Apellido="Fernandez" ,

                Habilidades=new List<Habilidad>()
              {
                  new Habilidad()
                  {
                      Id=1,
                      Nombre="Saltar",
                      Potencia=Habilidad.Epotencia.Moderado

                  },
                  new Habilidad() { Id=2,
                      Nombre="Corre",
                      Potencia=Habilidad.Epotencia.Suave


                  }
                }
            }

            };
        }
    } 
}            
            
            
    
