
public class Prototype_Cloneable implements Cloneable {
    private String ho;
    private String tenLot;
    private String ten;
 
    public Prototype_Cloneable(String ho, String tenLot, String ten) {
        super();
        this.ho = ho;
        this.tenLot = tenLot;
        this.ten = ten;
   
    }
 
    @Override
    protected Prototype_Cloneable clone() {
        try {
            return (Prototype_Cloneable) super.clone();
        } catch (CloneNotSupportedException e) {
            e.printStackTrace();
        }
        return null;
    }
 
    @Override
    public String toString() {
        return  ho +" " + tenLot + " " +ten ;
    }
 
    public void setTen(String ten) {
        this.ten = ten;
    }
}