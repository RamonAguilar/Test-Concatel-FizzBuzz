<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Rules of Fizz Buzz
    </h2>
    <p>
                Any number divisible by three is replaced by the word fizz and any divisible by five by the word buzz. Numbers divisible by both become
        fizzbuzz. A player who makes a mistake has to take a drink.
        Einstein will choose a random number to start with – for example: 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz, 13, 14, fizzbuzz...
        You are requested to implement a wcf webservice with a method that receive a integer with the random number to start and takes the limit
        from configuration, and that returns a List of strings with the correct Fizz Buzz serie, and register on a file the List as a string with a datetime
        signature. This web service has to be a RestFul web service. Moreover it have to be possible to call concurrently more than 100 time per
        seconds the method with no ploblems writing the serie on the file, and no bottlenecks.
    </p>
</asp:Content>
