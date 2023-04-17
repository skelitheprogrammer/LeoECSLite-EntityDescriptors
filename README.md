# LeoECSLite Entity Descriptors - Создание ентити через заранее описанный шаблон
# Содержание
* [Подключение](#Подключение)
* [ComponentProvider](#ComponentProvider)
  * [Описание дескриптора](#Описание-дескриптора)
* [EntityDescriptorExtender](#EntityDescriptorExtender)
* [Контакты](#Контакты)


# Социальные ресурсы
> #### Discord [Группа по LeoEcsLite](https://discord.gg/5GZVde6)
> #### Telegram [Группа по Ecs](https://t.me/ecschat)

# Установка
> **ВАЖНО!**
> <br> Зависит от [LeoECS Lite](https://github.com/Leopotam/ecslite) - фреймворк должен быть установлен до этого расширения.
> <br> Зависит от [Skillitronic LeoECS Lite Common](https://github.com/skelitheprogrammer/Skillitronic-LeoECSLite-Common)

## В виде unity модуля
Поддерживается установка в виде unity-модуля через git-ссылку в PackageManager:
```
https://github.com/skelitheprogrammer/LeoECSLite-Entity-Descriptors.git
```
или прямое редактирование `Packages/manifest.json`:
```
"com.skillitronic.leoecsentitydescriptors": "https://github.com/skelitheprogrammer/LeoECSLite-Entity-Descriptors.git",
```

# Подключение
Чтобы создавать ентити с помощью дескриптора, нужно объявить фабрику создания ентитей из дескрипторов.

```c#
  EntityInitializer playerInit = entityFactory.Create<PlayerEntityDescriptor>(world: world); // ref struct позволяющий настраивать данные компонентов
  int entity = playerInit.Entity;
  
  // Прокидывание данных
  playerInit.InitComponent(new UnitPosition()
  {
    Position = new Vector3(1f,0,1f);
  });
```

# ComponentProvider 
В основе любого дескриптора стоит набор провайдеров компонентов, которые будут описывать дескриптор.
>ComponentProvider унаследован от IComponentProvider интерфейса
## Описание дескриптора
```c#
  public class PlayerEntityDescriptor : IEntityDescriptor
  {
    private static readonly IComponentProvider[] providers =
    {
      new ComponentProvider<PlayerTag>(),
    };

    public IComponentProvider[] Components => providers;
    }
```
# EntityDescriptorExtender
С помощью дескрипторов можно выделять базовое поведение ентити в какой-либо тип, которую вы хотите создать. EntityDescriptorExtender позволяет расширять дескриптор какого то ентити не прибегая к дублированию описания дескриптора.
```c#
  public class UnitEntityDescritpor : IEntityDescriptor
  {
    private static readonly IComponentProvider[] providers =
    {
      new ComponentProvider<UnitPosition>(),
    };

    public IComponentProvider[] Components => providers;
  }

  public class PlayerEntityDescriptor : IEntityDescriptor
  {
    private static readonly IComponentProvider[] providers =
    {
      new ComponentProvider<PlayerTag>(),
      new EntityDescriptorExtender<UnitEntityDescriptor>
    };

    public IComponentProvider[] Components => providers;
   }
```

# Контакты
E-mail: dosynkirill@gmail.com </br>
Discord: @skilli на [сервере дискорд](#Социальные-ресурсы)
