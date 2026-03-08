public class Solution {

    /// <summary>
    /// Calcula el número mínimo de intervalos que se deben eliminar
    /// para que los intervalos restantes no se superpongan.
    /// Primero ordena los intervalos por su tiempo de finalización
    /// y luego revisa si cada intervalo se solapa con el anterior.
    /// 
    /// Args:
    ///     intervals: Arreglo de intervalos donde cada elemento tiene inicio y fin.
    /// 
    /// Returns:
    ///     Número mínimo de intervalos que se deben eliminar.
    /// 
    /// Complejidad:
    ///     Tiempo: O(n log n) por la ordenación de los intervalos.
    ///     Espacio: O(1).
    /// </summary>
    
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[1] - b[1]);

        int eliminados = 0;
        int finAnterior = intervals[0][1];

        for (int i = 1; i < intervals.Length; i++) {
            if (intervals[i][0] < finAnterior) {
                eliminados++;
            } else {
                finAnterior = intervals[i][1];
            }
        }

        return eliminados;
    }
}
