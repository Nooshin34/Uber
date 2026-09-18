-- Connect to NIKZAD\TUTORIAL with database [master] (leave Database Name empty or master).
-- Do not set Database Name to UberAdo until this script succeeds.

IF DB_ID(N'UberAdo') IS NULL
    CREATE DATABASE [UberAdo];
GO
