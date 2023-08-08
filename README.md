#### By _**Elle Hailu**_

#### _A web application to keep track of engineers and machines for maintanace_

## Technologies Used

- _C#_
- _.NET_
- _Bootstrap_
- Html
- CSS

## Description

- An MVC application to keep track of machine repairs. This application manages engineers and the machines the engineers are licensed to fix. The user is able to add a list of engineers, a list of machines, and specify which engineers are licesnsed to repair which machines. There is a many to many relationship between Engineers and Machines. An engineer can be licensed to repair many machines and a machine can have many engineers licensed to repair it.

## Setup/Installation Requirements

- _Clone this repository to your desktop_
- _Open your terminal and navigate to the top level of the directory_
- _Navigate to the production (Factory) directory in your terminal and run "dotnet restore" command_
- _Create a new file in your production folder and name it "appsettings.json"_
- _Update the contents of your appsettings.json file with:_

```
{
  "ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Port=3306;database=elle_hailu_factory;uid=[YOUR-USER-NAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
  }
```

- _Replace the place holder user name and password in the appsettings.json file with your actual username and password._
- _While in your your production folder run following command in your terminal:_

```
dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
```

- _To launch application remain in your production folder and run the command "dotnet run" in your terminal._

## Known Bugs

- _Application does not display an error message when user enter null values_

## License

MIT [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) _2023_ _Elle Hailu_

_Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_

_The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software._

_THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._
