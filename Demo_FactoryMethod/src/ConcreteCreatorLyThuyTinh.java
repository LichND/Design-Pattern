class ConcreteCreatorLyThuyTinh extends Creator {
	
	ConcreteCreatorLyThuyTinh() {

	}

	@Override
	public Product createProduct() {
		// TODO Auto-generated method stub
		return new ProductLyThuyTinh();
	}

}
