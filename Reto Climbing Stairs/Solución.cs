public class Solution {

    /// <summary>
    /// Calcula cuántas formas distintas hay de subir una escalera de n pasos
    /// si en cada movimiento se puede subir 1 o 2 pasos.
    /// 
    /// Args:
    ///     n: Número total de pasos de la escalera.
    /// 
    /// Returns:
    ///     Cantidad de formas distintas de llegar hasta arriba.
    /// 
    /// Complejidad:
    ///     Tiempo: O(n) porque se recorren los pasos una vez.
    ///     Espacio: O(1).
    /// </summary>
    
    public int ClimbStairs(int n) {
        if (n <= 2) return n;

        int anterior = 1;
        int actual = 2;

        for (int i = 3; i <= n; i++) {
            int siguiente = anterior + actual;
            anterior = actual;
            actual = siguiente;
        }

        return actual;
    }
}
