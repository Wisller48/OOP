public class TestarData {
    public static void main(String[] args){
        Data testeData;
        testeData = new Data();

        testeData.dia = 25;
        testeData.mes = 12;
        testeData.ano = 1981;

        testeData.escreverAData();
        testeData.escreverOMes();

        testeData.mes = 4;

        testeData.escreverAData();
        testeData.escreverOMes();
    }
}
