using Keras.Helper;
using Numpy;

namespace Keras.Datasets
{
    /// <summary>
    ///     Dataset of 60,000 28x28 grayscale images of 10 fashion categories, along with a test set of 10,000 images. This
    ///     dataset can be used as a drop-in replacement for MNIST. The class labels are:
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class FashionMNIST : Base
    {
        /// <summary>
        ///     Loads the data.
        /// </summary>
        /// <returns></returns>
        public static ((NDarray, NDarray), (NDarray, NDarray)) LoadData()
        {
            var dlist = TupleSolver.TupleToList(Instance.keras.datasets.fashion_mnist.load_data());
            return ((dlist[0], dlist[1]), (dlist[2], dlist[3]));
        }
    }
}