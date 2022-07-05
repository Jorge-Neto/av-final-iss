package br.com.iss.kafka.consumer.models;

public class Payroll {
	private int id;
    private int mes;
    private int ano;
    private int horas;
    private int valor;
    private double bruto;
    private double irrf;
    private double inss;
    private double fgts;
    private double liquido;
    private Employee funcionario;
    
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public int getMes() {
		return mes;
	}
	public void setMes(int mes) {
		this.mes = mes;
	}
	public int getAno() {
		return ano;
	}
	public void setAno(int ano) {
		this.ano = ano;
	}
	public int getHoras() {
		return horas;
	}
	public void setHoras(int horas) {
		this.horas = horas;
	}
	public int getValor() {
		return valor;
	}
	public void setValor(int valor) {
		this.valor = valor;
	}
	public double getBruto() {
		return bruto;
	}
	public void setBruto(double bruto) {
		this.bruto = bruto;
	}
	public double getIrrf() {
		return irrf;
	}
	public void setIrrf(double irrf) {
		this.irrf = irrf;
	}
	public double getInss() {
		return inss;
	}
	public void setInss(double inss) {
		this.inss = inss;
	}
	public double getFgts() {
		return fgts;
	}
	public void setFgts(double fgts) {
		this.fgts = fgts;
	}
	public double getLiquido() {
		return liquido;
	}
	public void setLiquido(double liquido) {
		this.liquido = liquido;
	}
	
	public Employee getFuncionario() {
		return funcionario;
	}
	public void setFuncionario(Employee funcionario) {
		this.funcionario = funcionario;
	}
}
