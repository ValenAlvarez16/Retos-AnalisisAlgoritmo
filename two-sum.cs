public class Solution {

    /// <summary>
    /// Devuelve los índices de los dos números del arreglo que suman el target.
    ///
    /// Funciona así:
    /// - Recorre cada número del arreglo.
    /// - Calcula cuánto falta para llegar al target con ese número.
    /// - Si ese número que falta ya apareció antes, devuelve los índices de ambos números.
    /// - Si no, guarda el número actual con su índice para revisarlo más adelante.
    ///
    /// Args:
    ///     nums: Arreglo de números enteros.
    ///     target: Número que queremos obtener sumando dos elementos del arreglo.
    ///
    /// Returns:
    ///     Arreglo de dos índices cuyos valores suman el target.
    ///
    /// Complejidad:
    ///     Tiempo: O(n) — se recorre el arreglo una sola vez.
    ///     Espacio: O(n) — se usa un diccionario para guardar los números vistos.
    /// </summary>
    
    public int[] TwoSum(int[] nums, int target) {

        var numerosGuardados = new Dictionary<int, int>(); // número -> índice

        for (int i = 0; i < nums.Length; i++) {
            int numeroActual = nums[i];
            int faltante = target - numeroActual;

            if (numerosGuardados.ContainsKey(faltante)) {
                return new int[] { numerosGuardados[faltante], i };
            }

            numerosGuardados[numeroActual] = i;
        }

        return new int[] { };
    }
}
