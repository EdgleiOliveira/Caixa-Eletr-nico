var builder = WebApplication.CreateBuilder(args);

// habilitar CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirTudo", p =>
        p.AllowAnyOrigin()
         .AllowAnyMethod()
         .AllowAnyHeader()
    );
});

var app = builder.Build();

// ativar CORS
app.UseCors("PermitirTudo");

decimal saldo = 1000;
string pinCorreto = "1234";

app.MapGet("/login", (string pin) =>
{
    if (pin == pinCorreto)
        return "Login realizado com sucesso!";
    return "PIN incorreto!";
});

app.MapGet("/saldo", () =>
{
    return $"Seu saldo é R$ {saldo}";
});

// >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
// NOVA ROTA DE SAQUE
// >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
app.MapPost("/sacar/{valor}", (decimal valor) =>
{
    if (valor <= 0)
        return "Valor inválido.";

    if (valor > saldo)
        return "Saldo insuficiente.";

    saldo -= valor;
    return $"Saque de R$ {valor} realizado. Saldo atual: R$ {saldo}";
});
// >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

app.Run();
