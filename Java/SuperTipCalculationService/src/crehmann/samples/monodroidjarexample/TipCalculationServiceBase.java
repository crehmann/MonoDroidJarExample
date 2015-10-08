package crehmann.samples.monodroidjarexample;

import java.util.ArrayList;

/**
 *
 * @author chris
 */
abstract class TipCalculationServiceBase implements TipCalculationService{

    @Override
    public TipCalculationResult calculateTip(TipRequest request) {
        TipCalculationResult result = new TipCalculationResult();
        switch(request.getSatisfaction()){
            case Awful:
                // Let them know you don't forget to tip
                result.setTip(0.1);
                break;
            case Poor:
                result.setTip(request.getPrice() * 0.05);
                break;
            case Ok:
                result.setTip(request.getPrice() * 0.1);
                break;
            case Good:
                result.setTip(request.getPrice() * 0.15);
                break;
            case Excellent:
                result.setTip(request.getPrice() * 0.2);
                break;
            default:
                result.setTip(0);
                break;
        }
        
        return result;
    }
}
