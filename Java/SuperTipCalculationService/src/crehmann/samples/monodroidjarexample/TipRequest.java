package crehmann.samples.monodroidjarexample;

/**
 *
 * @author chris
 */
public class TipRequest {

    private double mPrice;
    private Satisfaction mSatisfaction;

    public void setPrice(double price) {
        this.mPrice = price;
    }
    
    public double getPrice(){
        return this.mPrice;
    }

    public void setSatisfaction(Satisfaction satisfaction) {
        this.mSatisfaction = satisfaction;
    }
    
    public Satisfaction getSatisfaction(){
        return this.mSatisfaction;
    }
}
