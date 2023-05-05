using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerc4
{
    class Program
    {
        class Vehiculo
        {
            int id;
            string marca;
            string modelo;
            int km;
            decimal precio;
            int annio;

            public Vehiculo(int id, string marca, string modelo, int km, decimal precio, int annio)
            {
                this.Id = id;
                this.Marca = marca;
                this.Modelo = modelo;
                this.Km = km;
                this.Precio = precio;
                this.Annio = annio;
            }

            public int Id { get => id; set => id = value; }
            public string Marca { get => marca; set => marca = value; }
            public string Modelo { get => modelo; set => modelo = value; }
            public int Km { get => km; set => km = value; }
            public decimal Precio { get => precio; set => precio = value; }
            public int Annio { get => annio; set => annio = value; }

            public override string ToString()
            {
                return $"Id: {Id}, Marca: {Marca}, Modelo: {Modelo}, Km: {Km}, Precio: {Precio}, Año: {Annio}";
            }
            public virtual decimal CalcularPrecio()
            {
                return Precio;
            }

        }
        class Auto : Vehiculo
        {
            bool airbag;
            public Auto(int id, string marca, string modelo, int km, decimal precio, int annio, bool airbag) : base(id, marca, modelo, km, precio, annio)
            {
                this.airbag = airbag;
            }
            public bool Airbag { get => airbag; }
            public override decimal CalcularPrecio()
            {
                if (airbag)
                {
                    return base.CalcularPrecio() + 200;
                }
                else { return base.CalcularPrecio(); }
            }
            public override string ToString()
            {
                return "Modelo: " + Modelo + " Marca: " + Marca + " Año: " + Annio + " Precio: " + CalcularPrecio();
            }
        }
        class Moto : Vehiculo
        {
            bool sidecar;
            public Moto(int id, string marca, string modelo, int km, decimal precio, int annio, bool sidecar) : base(id, marca, modelo, km, precio, annio)
            {
                this.sidecar = sidecar;
            }
            public bool Sidecar { get => sidecar; }
            public override decimal CalcularPrecio()
            {
                if (sidecar)
                {
                    return base.CalcularPrecio() + 50;
                }
                else { return base.CalcularPrecio(); }
            }
            public override string ToString()
            {
                return "Modelo: " + Modelo + " Marca: " + Marca + " Año: " + Annio + " Precio: " + CalcularPrecio();
            }
        }

        static void Main(string[] args)
        {
            //Clase Vehiculo
            Vehiculo vehiculo = new Vehiculo(1, " Land Rover", "Range Rover Evoque", 10000, 100000, 2019);
            Console.WriteLine(vehiculo.ToString());
            Console.WriteLine("--------------------------");

            Console.WriteLine("Ingrese el id del vehiculo");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la marca del vehiculo");
            string marca = Console.ReadLine();
            Console.WriteLine("Ingrese el modelo del vehiculo");
            string modelo = Console.ReadLine();
            Console.WriteLine("Ingrese los km del vehiculo");
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del vehiculo");
            decimal precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año del vehiculo");
            int annio = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese si el vehiculo tiene airbag");
            //bool airbag = bool.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------");
            Auto auto = new Auto(id, marca, modelo, km, precio, annio, false);
            Console.WriteLine(auto.ToString());
            Console.WriteLine("--------------------------");


            //Clase Moto
            Moto moto = new Moto(2, "Honda", "CBR 1000 RR", 10000, 100000, 2019, false);
            Console.WriteLine(moto.ToString());

            Console.ReadKey();
        }
    }
}
