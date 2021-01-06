package pure;

public class ConcretePrototype extends Prototype_Pure {
	String ho;
	String ten;
	String tenLot;

	public ConcretePrototype(String ho, String tenLot, String ten) {
		this.ho = ho;
		this.tenLot = tenLot;
		this.ten = ten;
	}

	public ConcretePrototype(ConcretePrototype cr) {
		this.ho = cr.ho;
		this.tenLot = cr.tenLot;
		this.ten = cr.ten;
	}

	@Override
	public Prototype_Pure clone() {
		return new ConcretePrototype(this);// Clones the concrete class.
	}
	
	@Override
    public String toString() {
        return  ho +" " + tenLot + " " +ten ;
    }

}