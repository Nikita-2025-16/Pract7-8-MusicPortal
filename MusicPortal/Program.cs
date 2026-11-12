var builder = WebApplication.CreateBuilder(args);

// Додаємо підтримку Razor Pages у проєкт
builder.Services.AddRazorPages();

var app = builder.Build();

// Налаштування HTTP-конвеєра (Pipeline)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Вказуємо, що стандартна маршрутизація йде на Razor Pages (відкриється Index.cshtml)
app.MapRazorPages();

app.Run();