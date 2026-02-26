public class Solution {

    /// <summary>
    /// Devuelve la suma más grande posible de un subarray contiguo.
    ///
    /// Recorro el arreglo acumulando la suma. Si en algún momento la suma 
    /// se vuelve negativa, la reinicio desde el elemento actual, porque 
    /// continuar con una suma negativa no ayuda a obtener un valor mayor. 
    /// Siempre guardo el mayor valor que encuentre durante el recorrido.
    ///
    /// Args:
    ///     nums: Arreglo de números enteros.
    ///
    /// Returns:
    ///     La suma más grande de cualquier subarray contiguo.
    ///
    /// Complejidad:
    ///     Tiempo: O(n) — recorremos el arreglo solo una vez.
    ///     Espacio: O(1) — solo usamos un par de variables extra.
    /// </summary>
    
    public int MaxSubArray(int[] nums) {
        int sumaActual = nums[0];
        int sumaMaxima = nums[0];

        for (int i = 1; i < nums.Length; i++) {
            if (sumaActual < 0)
                sumaActual = nums[i];
            else
                sumaActual += nums[i];

            if (sumaActual > sumaMaxima)
                sumaMaxima = sumaActual;
        }

        return sumaMaxima;
    }
}
