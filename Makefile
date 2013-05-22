all:
	@echo You can use this makefile to update docs
	@echo type "make update-docs"

DOCS_PATH=docs

DOCS_ASSEMBLIES=cocos2d/bin/MacOS/Debug/cocos2d-xna.dll

update-docs: $(DOCS_ASSEMBLIES)
	mdoc update --delete $(MDOC_UPDATE_OPTIONS) -o docs/en $(DOCS_ASSEMBLIES)

