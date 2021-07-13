namespace Keras.Layers
{
    /// <summary>
    ///     Exponential Linear Unit.
    ///     It follows: f(x) =  alpha* (exp(x) - 1.) for x< 0, f( x)= x for x>= 0.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class ELU : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ELU" /> class.
        /// </summary>
        /// <param name="alpha"> scale for the negative factor.</param>
        public ELU(float alpha = 1)
        {
            Parameters["alpha"] = alpha;

            PyInstance = Instance.keras.layers.LeakyReLU;
            Init();
        }
    }
}