
public abstract class SlideTemplate {
	protected void IntroduceGroup() {
		System.out.println("Thanh vien nhom: ... ");
	}

	abstract protected void IntroducePattern();

	abstract protected void ShowClassDiagram();

	abstract protected void ComponentsRole();

	abstract protected void ShowDemo();
	
	protected void QandA() {
		System.out.println("Cac ban co thac mac gi khong");
	}

	public final void Present() {
		IntroduceGroup();
		IntroducePattern();
		ShowClassDiagram();
		ComponentsRole();
		ShowDemo();
		QandA();
	}
}
