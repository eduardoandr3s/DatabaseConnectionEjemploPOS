namespace DatabaseConnectionEjemploPOS
{
    using System;
    using System.Data;
    using System.Data.OleDb;
    internal class Program
    {
        static void Main(string[] args)
        {

            DatabaseConnection db = DatabaseConnection.GetInstance();


            // string query2 = "INSERT INTO Productos(Nombre, Precio, Cantidad, Tipo, Impuesto) VALUES('La Vorágine', 40,12 ,'Libro', 0.1)";
            string query2 = "DELETE FROM Productos WHERE Nombre = 'La Vorágine'";


            int ra = db.ExecuteNonQuery(query2);
            Console.WriteLine("Filas afectadas: "+ ra);

            string query1 = "SELECT * FROM Productos";

            DataTable dt = db.ExecuteQuery(query1);

            foreach (DataRow row in dt.Rows)
            {

                Console.WriteLine($"ID: {row["id"]}; Nombre: {row["Nombre"]}");

            }

        }
    }
}
