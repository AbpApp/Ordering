# Paths
$packFolder = (Get-Item -Path "./" -Verbose).FullName
$rootFolder = Join-Path $packFolder "../"

# List of solutions，解决方案的文件夹
$solutions = (
    ""
)

# List of projects
$projects = (

    # aspnet-core
    "src/Abp.Module.Ordering.Application",
    "src/Abp.Module.Ordering.Application.Contracts",
    "src/Abp.Module.Ordering.Domain",
    "src/Abp.Module.Ordering.Domain.Shared",
    "src/Abp.Module.Ordering.EntityFrameworkCore",
    "src/Abp.Module.Ordering.HttpApi",
    "src/Abp.Module.Ordering.HttpApi.Client",
    "src/Abp.Module.Ordering.MongoDB"
)