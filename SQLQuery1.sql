CREATE TABLE Livros(
                nlivro int identity primary key,
                titulo varchar(50) not null,
                autor varchar(100),
                isbn char(13),
                ano int check(ano > 0),
                data_aquisicao date default getdate(),
                preco money check (preco>=0),
                capa varchar(500),
                estado bit default 1

            )