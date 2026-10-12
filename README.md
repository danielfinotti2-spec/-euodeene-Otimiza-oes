# Optimizer — edição personalizada por @euodeene

## Quer apenas baixar o aplicativo?

- [Baixar só o executável: Optimizer.exe](download/Optimizer.exe)
- [Baixar o pacote portátil (.zip)](download/Optimizer-portable.zip) — inclui o executável, a configuração e a licença.

O programa funciona no Windows e requer o **.NET Framework 4.8**. O aplicativo pede permissão de administrador ao iniciar. Ele pode alterar configurações do Windows, como Registro, serviços e tarefas agendadas; leia cada opção antes de aplicá-la e mantenha um ponto de restauração ou backup.

### Conferir o arquivo

O executável não tem assinatura digital. O SHA-256 está em [`download/SHA256SUMS.txt`](download/SHA256SUMS.txt). No PowerShell, confira com:

```powershell
Get-FileHash .\Optimizer.exe -Algorithm SHA256
```

Compare o valor retornado com o arquivo de hash. Isso verifica se o arquivo foi alterado depois de publicado; não substitui a confirmação de que a origem é confiável. Se o Windows exibir um aviso, não o ignore sem verificar a origem do arquivo.

## Sobre esta edição

Esta é uma edição personalizada do **Optimizer**, com documentação em português, interface em preto e branco e telas de carregamento com artes de @euodeene. É derivada do projeto [hellzerg/optimizer](https://github.com/hellzerg/optimizer) e não é oficial nem afiliada ao projeto original.

O código-base é distribuído sob a **GNU GPL v3.0**. Consulte [`LICENSE`](LICENSE). O código-fonte está na pasta `Optimizer`; para compilar, abra `Optimizer.sln` no Visual Studio com o .NET Framework 4.8 Developer Pack.

## Contato — @euodeene

- GitHub: [danielfinotti2-spec](https://github.com/danielfinotti2-spec)
- Instagram: [@euodeene](https://www.instagram.com/euodeene/)
- Discord: [servidor da comunidade](https://discord.gg/am9s4fqRHw)
- X: [@euodeene](https://x.com/euodeene)
