
abstract class Handler {
	private Handler handler;
	protected void Handler(Handler handler) {
			this.handler = handler; 
	}

	protected void setNext() {
		
	}

	protected void handleMoney(int money) {
		if(handler != null) 
            handler.handleMoney(money); 
	}

}
