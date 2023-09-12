namespace csharp_calcolatrice
{
    internal partial class Program
    {
        // Creare una classe di helper CalcoliHelper
        public static class CalcoliHelper
        {
            // Somma di due numeri interi
            public static int Sum(int x, int y) { 
            return x + y;}
            // Somma di due numeri double
            public static double Sum(double x, double y) { 
            return x + y;}
            // Differenza tra due numeri interi
            public static int Sub(int x, int y) {
                return x - y;
            }
            // Differenza tra due numeri double
            public static double Sub(double x, double y) {
                return x - y;
            }
            // Moltiplicazione di due numeri interi
            public static int Mult(int x, int y) {
                return x * y;
            }
            //Moltiplicazione di due numeri double
            public static double Mult(double x, double y) {
                return x * y;            
            }
            //Valore assoluto di un numero intero
            public static int Absolute(int x) {
                return Math.Abs(x);
            }
            //Valore assoluto di un numero double
            public static double Absolute(double x) {
                return Math.Abs(x);
            }
            // Minimo tra due numeri interi
            public static int Min(int x, int y) {
                return Math.Min(x, y);
            }
            // Minimo tra due numeri double
            public static double Min(double x, double y) {
                return Math.Min(x, y);
            }
            // Massimo tra due numeri interi
            public static int Max(int x, int y) {
                return Math.Max(x, y);
            }
            
            //Massimo tra due numeri double
            public static double Max(double x, double y) {
                return Math.Max(x, y);
            }

            // Domanda
            // Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi di programmazione ad oggetti che abbiamo visto...Quale?
            // Il principio di polimorfismo È il principio che permette di scrivere più metodi con lo stesso nome, ma che accedono alla stessa logica ma con parametri diversi.

            // BONUS
            // Aggiungete il metodo per l’elevamento a potenza che prende come parametri due numeri interi (base ed esponente) e ritorna la base elevata all’esponente.
            public static int Elevate(int x, int y) {
                return (int)Math.Pow(x,y);
            }

            // SUPER BONUS 110%
            // con l'uso dei generics si può risparmiare linee di codice ed implementare un metodo che prenda come parametri due tipi di dato diversi e ritorni il valore della somma, nonostante bisogna tener conto di alcuni accorgimenti sulle operazioni ammesse con i Generics.
            public static T SumGenerics<T>(T x, T y) where T : IConvertible
            {
                // Convert T to double, perform addition, and then convert back to T
                double dx = Convert.ToDouble(x);
                double dy = Convert.ToDouble(y);
                double result = dx + dy;
                return (T)Convert.ChangeType(result, typeof(T));
            }



        }
    }
}