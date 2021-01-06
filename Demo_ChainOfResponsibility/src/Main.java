
public class Main {

	public static void main(String[] args) {
		Handler handler = new Handler_500(new Handler_200(new Handler_100(null)));
		handler.handleMoney(800000);
	}

}
