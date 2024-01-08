using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using NLayers.Core.Repositories;
using NLayers.Core.Services.Abstract;
using NLayers.Repository.DbContexts;
using NLayers.Repository.Repositories;
using NLayers.Repository.Services.Concrete;
using NLayers.Services.Mapper;
using NLayers.Services.Services.Concrete;
using System.Reflection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
});
//Services
builder.Services.AddAutoMapper(typeof(MapProfile));
builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();


builder.Services.AddScoped(typeof(ICertificateService), typeof(CertificateService));
builder.Services.AddScoped(typeof(ICompanyInfoService), typeof(CompanyInfoService));
builder.Services.AddScoped(typeof(ICompanyUserRoleService), typeof(CompanyUserRoleService));
builder.Services.AddScoped(typeof(IKnownProgramService), typeof(KnownProgramService));
builder.Services.AddScoped(typeof(ISchoolDepartmentService), typeof(SchoolDepartmentService));
builder.Services.AddScoped(typeof(ISchoolInformationService), typeof(SchoolInformationService));
builder.Services.AddScoped(typeof(ISpeakingLanguageService), typeof(SpeakingLanguageService));
builder.Services.AddScoped(typeof(IUserService), typeof(UserService));

//Repositories
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(ICertificateRepository), typeof(CertificateRepository));
builder.Services.AddScoped(typeof(ICompanyInfoRepository), typeof(CompanyInfoRepository));
builder.Services.AddScoped(typeof(ICompanyUserRoleRepository), typeof(CompanyUserRoleRepository));
builder.Services.AddScoped(typeof(IKnownProgramRepository), typeof(KnownProgramRepository));
builder.Services.AddScoped(typeof(ISchoolDepartmentRepository), typeof(SchoolDepartmentRepository));
builder.Services.AddScoped(typeof(ISchoolInformationRepository), typeof(SchoolInformationRepository));
builder.Services.AddScoped(typeof(ISpeakingLanguageRepository), typeof(SpeakingLanguageRepository));
builder.Services.AddScoped(typeof(IUserRepository), typeof(UserRepository));


//DbContext
builder.Services.AddDbContext<AppDbContext>(options => 
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"),option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);

    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
