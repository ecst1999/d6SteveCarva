using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DeberS6SteveCarvajal.Models
{
    class DBConection<T>
    {
        public List<T> valores = new List<T>();
        public string ruta;

        public DBConection(string r)
        {
            ruta = r;
        }
        public void Guardar()
        {
            string texto = JsonConvert.SerializeObject(valores);
            File.WriteAllText(ruta, texto);
        }

        public void Cargar()
        {
            try
            {

            string archivo = File.ReadAllText(ruta);
            valores = JsonConvert.DeserializeObject<List<T>>(archivo);
            }
            catch (Exception)
            {

            }
        }

        public void Insertar(T nuevo)
        {
            valores.Add(nuevo);
            Guardar();
        }

        public List<T> Buscar(Func<T, bool> criterio)
        {
            return valores.Where(criterio).ToList();
        }

        public void Actualizar(Func<T, bool> criterio, T nuevo)
        {
            valores = valores.Select(x =>
            {
                if (criterio(x)) x = nuevo;
                return x;
            }).ToList();

            Guardar();
        }
    }
}
