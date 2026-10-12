# Automação por arquivo de configuração

Documentação desta edição preparada por @euodeene, em 12/10/2026. Antes de usar uma configuração automática, revise cada opção: ela pode alterar serviços, tarefas, políticas e configurações do Windows.

## Modelos incluídos

- [Windows 7](templates/template-windows7.json)
- [Windows 8](templates/template-windows8.json)
- [Windows 10](templates/template-windows10.json)
- [Windows 11](templates/template-windows11.json)

## Como usar

1. Faça uma cópia do modelo adequado e revise os valores.
2. Salve o arquivo ao lado do executável como `template.json`.
3. Execute no Prompt de Comando com privilégios de administrador:

   ```text
   Optimizer.exe /config=template.json
   ```

O campo `WindowsVersion` deve corresponder à versão instalada (`7`, `8`, `10` ou `11`). Os campos de limpeza, DNS, processos, hosts e ajustes do Windows são descritos dentro dos próprios modelos. Não use um modelo sem revisar cada ação.

Esta edição personalizada não inclui modelos novos para todas as versões do Windows. Consulte [README.md](README.md) e [LICENSE](LICENSE). Contato: [GitHub](https://github.com/danielfinotti2-spec), [Instagram](https://www.instagram.com/euodeene/), [Discord](https://discord.gg/am9s4fqRHw) e [X/Twitter](https://x.com/euodeene).
