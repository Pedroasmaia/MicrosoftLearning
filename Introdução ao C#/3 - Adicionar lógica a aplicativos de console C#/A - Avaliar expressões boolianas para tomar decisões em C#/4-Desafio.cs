   //Todo Comece com esse código:
   string permission = "Admin";
   int level = 55;

   // Se o usuário for um administrador com um nível maior que 55, exiba a mensagem:
   // Output: Welcome, Super Admin user.

   //Se o usuário for um administrador com um nível menor ou igual a 55, exiba a mensagem:
   // Output: Welcome, Admin user.

   //Se o usuário for um gerente com um nível maior ou igual a 20, exiba a mensagem:
   // Output: Contact an Admin for access.

   //Se o usuário for um gerente com um nível menor que 20, exiba a mensagem:
   // Output:  You do not have sufficient privileges.

   // Se o usuário não for um administrador nem um gerente, exiba a mensagem:
   // Output: You do not have sufficient privileges.
   if(permission.Contains("Admin")){
      Console.WriteLine(level > 55 ? "Welcome,Super Admin user." : "Welcome, Admin user.");
   }
   else if(permission.Contains("Manager")){
      Console.WriteLine(level >= 20 ? "Contact an Admin for access" : "You do not have sufficient privileges");
   }
   else
   {
      Console.WriteLine("You do not have sufficient privileges");
   }