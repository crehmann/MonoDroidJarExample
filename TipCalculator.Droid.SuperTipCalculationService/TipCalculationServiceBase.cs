using Java.Lang;

namespace Crehmann.Samples.Monodroidjarexample
{
    public abstract partial class TipCalculationServiceBase
    {
        Object ITipCalculationService.CalculateTip(TipRequest p0)
        {
            return CalculateTip(p0);
        }
    }
}