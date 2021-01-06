import java.util.Random;

class ProductLyThuyTinh implements Product {
	final String tenSP = "Ly Thuy Tinh";
	
	@Override
	public String randomMa() {
		// TODO Auto-generated method stub
		Random rand = new Random();
		return "LTT_" + (rand.nextInt(89) + 10);
	}

	@Override
	public void printInfo() {
		System.out.println("Ten san pham: " + tenSP);
		System.out.println("\nMa san pham: "+ randomMa());
	}

}
