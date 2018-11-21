}
printf("\n\n");
// Obtenção da resposta do aluno
// Obtenção da resposta do aluno
printf("Aluno %d\n", a+1);
for (i = 0; i< 10; i++){
    printf("A resposta da questao %d: ", i+1);
scanf("%s", &resposta[i]);   
}
 // Impressão de tabela
// Impressão de tabela
printf("\n\nQuestao\tRespostaGabaritoSituacao\n");
for (i = 0; i< 10; i++){
    if (resposta[i] == gabarito[i]){