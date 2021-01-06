
public class RefinedAbstract_FEdev implements Abstract_FEdev {

	private Implementor_Design imp;
	
	public RefinedAbstract_FEdev(Implementor_Design imp) {
		// TODO Auto-generated constructor stub
		this.imp = imp;
	}
	
	@Override
	public void devUI() {
		// TODO Auto-generated method stub
		
		System.out.println("<div>"+imp.designHeader()+"</div>");	
		System.out.println("<div>"+imp.designHomepage()+"</div>");
		System.out.println("<div>"+imp.designFooter()+"</div>");
	}

	@Override
	public void devEvent() {
		// TODO Auto-generated method stub
		System.out.println("onClickHeaderMenuItem = () => {console.log('clicked')}"); 
	} 
	
}
