_ != mkdir -p bin

DOTNET ?= dotnet

CS_SRC   != find . -path '*.cs'
PROJ_SRC != find . -path '*.*proj'

build: bin/sql2csharp

format:
	$(DOTNET) format

bin/sql2csharp: | src/sql2csharp/bin/Debug/net10.0/sql2csharp
	rm -f $@ && ln -s ${CURDIR}/$| ${CURDIR}/$@

src/sql2csharp/bin/Debug/net10.0/sql2csharp: ${CS_SRC} ${PROJ_SRC}
	$(DOTNET) build

.git/hooks/pre-commit: hack/pre-commit.sh
	cp $< $@
