namespace Keras
{
    /// <summary>
    ///     Initializer that generates the identity matrix.
    ///     Only use for 2D matrices.If the desired matrix is not square, it pads with zeros on the additional rows/columns
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class Identity : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Identity" /> class.
        /// </summary>
        /// <param name="gain">Multiplicative factor to apply to the identity matrix.</param>
        public Identity(float gain = 1.0f)
        {
            Parameters["gain"] = gain;
            PyInstance = Instance.keras.initializers.Identity;
            Init();
        }
    }
}