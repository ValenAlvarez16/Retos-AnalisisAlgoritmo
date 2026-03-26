public class Solution {

    /// <summary>
    /// Calcula el máximo dinero que se puede robar sin tomar casas adyacentes.
    /// Va decidiendo en cada casa si conviene robarla o saltarla según lo acumulado.
    ///
    /// Args:
    ///     nums: Arreglo con el dinero de cada casa.
    ///
    /// Returns:
    ///     Máximo dinero que se puede obtener.
    ///
    /// Complejidad:
    ///     Tiempo: O(n) porque se recorre el arreglo una sola vez.
    ///     Espacio: O(1) ya que solo se guardan los valores anteriores.
    /// </summary>

    public int Rob(int[] nums) {
        int anterior = 0;
        int actual = 0;

        foreach (int casa in nums) {
            int temp = Math.Max(actual, anterior + casa);
            anterior = actual;
            actual = temp;
        }

        return actual;
    }
}
