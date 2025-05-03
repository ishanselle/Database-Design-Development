-- Create the Quiet Attic Films database
CREATE DATABASE [QuietAttic Films];
GO

-- Use the Quiet Attic Films database
USE [QuietAttic Films];
GO
-- Create the Client table
CREATE TABLE Client (
    ID INT PRIMARY KEY,
    Name VARCHAR(100),
    [Contact No] INT,
    Address VARCHAR(100),
    Email VARCHAR(100)
);

-- Create the Production table
CREATE TABLE Production (
    ID INT PRIMARY KEY,
    Name VARCHAR(100),
    [Production Type] VARCHAR(100),
    Date DATETIME,
    [Client ID] INT,
    FOREIGN KEY ([Client ID]) REFERENCES Client(ID)
);

-- Create the Property table
CREATE TABLE Property (
    ID INT PRIMARY KEY,
    Name VARCHAR(100),
    Description VARCHAR(100),
    [Property Type] VARCHAR(100),
    [Production ID] INT,
    FOREIGN KEY ([Production ID]) REFERENCES Production(ID)
);

-- Create the Location table
CREATE TABLE Location (
    ID INT PRIMARY KEY,
    Name VARCHAR(100),
    Address VARCHAR(100),
    [Contact No] INT,
    [Location Type] VARCHAR(100),
    [Production ID] INT,
    FOREIGN KEY ([Production ID]) REFERENCES Production(ID)
);

-- Create the Staff table
CREATE TABLE Staff (
    ID INT PRIMARY KEY,
    Name VARCHAR(100),
    [Staff Type] VARCHAR(100),
    [Working Day] INT,
    Salary INT,
    [Production ID] INT,
    FOREIGN KEY ([Production ID]) REFERENCES Production(ID)
);

-- Create the Payment table
CREATE TABLE Payment (
    ID INT PRIMARY KEY,
    Date DATETIME,
    Method VARCHAR(100),
    Amount INT,
    [Production ID] INT,
    FOREIGN KEY ([Production ID]) REFERENCES Production(ID)
);
