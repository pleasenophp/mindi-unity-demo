.DEFAULT_GOAL := build
include config.mk

MINDI_LIB=Assets/Plugins/mindi/lib

import:
	rm -rf $(MINDI_LIB)
	mkdir $(MINDI_LIB)
	cp $(MINDI_PATH)/mindi-interop.dll $(MINDI_LIB)/
	cp $(MINDI_PATH)/mindi.dll $(MINDI_LIB)/
	cp $(MINDI_PATH)/minioc.dll $(MINDI_LIB)/
	cp $(MINDI_PATH)/mindi-unity.dll $(MINDI_LIB)/
style:
	astyle --recursive --options=style.astyle "Assets/*.cs"

