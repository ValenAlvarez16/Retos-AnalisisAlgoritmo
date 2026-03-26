public class Solution {

    /// <summary>
    /// Calcula el costo mínimo para llegar a la cima de la escalera.
    /// Va comparando si conviene llegar desde un paso o desde dos pasos atrás.
    ///
    /// Args:
    ///     cost: Arreglo con el costo de cada escalón.
    ///
    /// Returns:
    ///     Costo mínimo para llegar a la cima.
    ///
    /// Complejidad:
    ///     Tiempo: O(n) porque se recorre el arreglo una sola vez.
    ///     Espacio: O(1) ya que solo se guardan los valores anteriores.
    /// </summary>

    public int MinCostClimbingStairs(int[] cost) {
        int anterior = 0;
        int actual = 0;

        for (int i = 2; i <= cost.Length; i++) {
            int temp = Math.Min(actual + cost[i - 1], anterior + cost[i - 2]);
            anterior = actual;
            actual = temp;
        }

        return actual;
    }
}
