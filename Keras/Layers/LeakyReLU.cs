namespace Keras.Layers
{
    /// <summary>
    ///     Leaky version of a Rectified Linear Unit.
    ///     It allows a small gradient when the unit is not active: f(x) = alpha* x for x< 0, f( x)= x for x>= 0.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class LeakyReLU : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="LeakyReLU" /> class.
        /// </summary>
        /// <param name="alpha">float >= 0. Negative slope coefficient.</param>
        public LeakyReLU(float alpha = 0.3f)
        {
            Parameters["alpha"] = alpha;

            PyInstance = Instance.keras.layers.LeakyReLU;
            Init();
        }
    }
}