# AWS Configuration options exploration project

[![.NET Build](https://github.com/mrnustik/AwsConfiguration/actions/workflows/dotnet.yml/badge.svg)](https://github.com/mrnustik/AwsConfiguration/actions/workflows/dotnet.yml)

## Projects list

- `AwsConfiguration.AppConfig` - project that is using [AWS AppConfig](https://docs.aws.amazon.com/appconfig/latest/userguide/what-is-appconfig.html) service for configuration
- `AwsConfiguration.Parameters` - project that is using [AWS Systems Manager Parameter Store](https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-parameter-store.html) for configuration

## Expected settings in AWS AppConfig

**Environments:** Development, Production

Configuration profile values:

```json
{
  "MyKey": {
    "SomeStringOption": "SomeString",
    "BooleanOption": false,
    "IntegerOption": 42
  }
}
```

## Expected settings in AWS Parameter Store

- `Development/MyKey/BooleanOption`
- `Development/MyKey/IntegerOption`
- `Development/MyKey/SomeStringOption`
- `Production/MyKey/BooleanOption`
- `Production/MyKey/IntegerOption`
- `Production/MyKey/SomeStringOption`
