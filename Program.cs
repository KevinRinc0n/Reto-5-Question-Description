static int diferencia (int samDaily, int kellyDaily, int diferen)
{
    if (samDaily < 0 || kellyDaily >100 || diferen < 0 || diferen > 100){
        return -1;
    }
    else{
        int resuelveSam = diferen;
        int resuelveKelly = 0;

        int dias = 0;

        while (resuelveSam >= resuelveKelly){
            resuelveSam += samDaily;
            resuelveKelly += kellyDaily;
            dias++;
        }
        return dias;
    }
}

Console.WriteLine(diferencia(3,5,5));

/////////////////////////////////

// static int secuencia (int[] array){
//     for (int i = 0;i < array.Length;i++)
//     {
//         if (array[i] <0 || array[i] > Math.Pow(10,9)){
//             return -1;
//         }
//     }
//     if(array.Length < 3 || )
//     {
//         return -1;
//     }

//     else
//     {
        
//     }
// }