Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
//!Use duas instruções IF para implementar as seguintes regras de negócios (ramificação ou aninhamento três na primeira instrução IF)
//todo Regra 1. Se a assinatura do usuário expirar em dez dias ou menos, será exibida a mensagem:
// Your subscription will expire soon. Renew now!
//todo Regra 2. Se a assinatura do usuário for expirar em cinco dias ou menos, exiba as mensagens:
//Your subscription expires in x days.
//Renew now and save 10%!
//todo Regra 3. Se a assinatura do usuário for expirar em um dia, exiba a mensagem:
//Your subscription expires within a day!
//Renew now and save 20%!
//todo Regra 4. Se a assinatura do usuário tiver expirado, será exibida a mensagem:
//Your subscription has expired.
//todo Regra 5. Se a assinatura do usuário expirar em mais de dez dias, nada será exibido.

if(daysUntilExpiration <= 0){
   Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration <= 1)
{
discountPercentage = 20;
Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 5)
{
discountPercentage = 10;
Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 10)
{
   Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else{
}
