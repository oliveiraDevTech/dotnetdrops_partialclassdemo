
# PartialClassDemo

Este projeto demonstra como usar `partial class` no C# para organizar melhor o código, separando responsabilidades em arquivos diferentes.

---

### 🧹 .NET Drop: Use `partial class` pra manter seu código limpo e modular

Já teve aquela classe que cresceu tanto que ficou impossível de manter?  
Vários métodos, propriedades, validações, eventos… tudo embolado num só arquivo?

Tá na hora de usar **`partial class`** e dividir o caos. ✂️

---

### 🔍 O que é uma `partial class`?

É uma forma de **separar uma única classe em vários arquivos**, mantendo tudo organizado por responsabilidade.

---

### 🧪 Exemplo neste projeto

**Arquivo: `Cliente.Model.cs`**

```csharp
public partial class Cliente
{
    public string Nome { get; set; }
    public string Email { get; set; }
}
```

**Arquivo: `Cliente.Validations.cs`**

```csharp
public partial class Cliente
{
    public bool EmailValido()
        => Email?.Contains("@") == true;
}
```

💥 No final, o compilador junta tudo como uma única classe `Cliente`.

---

### 💡 Quando usar `partial`?

✅ Em **entidades grandes** com muitas responsabilidades  
✅ Quando quiser separar **validações**, **eventos**, **extensões**  
✅ Em projetos com **geração de código automática** (ex: WinForms, EF, gRPC)

---

### ⚠️ Cuidado

- Não abuse: dividir demais também confunde  
- Mantenha uma **nomenclatura clara** nos arquivos (ex: `.Model`, `.Events`, `.Rules`)

---

### 🧩 Resumo

- `partial class` ajuda a **organizar grandes classes**  
- Você pode separar responsabilidades por arquivo  
- Ganha **clareza**, **manutenibilidade** e menos stress

---

💬 Já usou `partial` em algum projeto?  
Conta aí como você organiza suas classes grandes e segue o **.NET Drops** pra mais truques de organização que dev sênior adora. 🚀🧼
