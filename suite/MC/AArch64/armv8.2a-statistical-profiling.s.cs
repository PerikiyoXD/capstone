# CS_ARCH_AARCH64, 0, None
0x3f,0x22,0x03,0xd5 = psb	csync
0x00,0x9a,0x18,0xd5 = msr	PMBLIMITR_EL1, x0
0x20,0x9a,0x18,0xd5 = msr	PMBPTR_EL1, x0
0x60,0x9a,0x18,0xd5 = msr	PMBSR_EL1, x0
0x00,0x99,0x1c,0xd5 = msr	PMSCR_EL2, x0
0x00,0x99,0x1d,0xd5 = msr	PMSCR_EL12, x0
0x00,0x99,0x18,0xd5 = msr	PMSCR_EL1, x0
0x40,0x99,0x18,0xd5 = msr	PMSICR_EL1, x0
0x60,0x99,0x18,0xd5 = msr	PMSIRR_EL1, x0
0x80,0x99,0x18,0xd5 = msr	PMSFCR_EL1, x0
0xa0,0x99,0x18,0xd5 = msr	PMSEVFR_EL1, x0
0xc0,0x99,0x18,0xd5 = msr	PMSLATFR_EL1, x0
0x00,0x9a,0x38,0xd5 = mrs	x0, PMBLIMITR_EL1
0x20,0x9a,0x38,0xd5 = mrs	x0, PMBPTR_EL1
0x60,0x9a,0x38,0xd5 = mrs	x0, PMBSR_EL1
0xe0,0x9a,0x38,0xd5 = mrs	x0, PMBIDR_EL1
0x00,0x99,0x3c,0xd5 = mrs	x0, PMSCR_EL2
0x00,0x99,0x3d,0xd5 = mrs	x0, PMSCR_EL12
0x00,0x99,0x38,0xd5 = mrs	x0, PMSCR_EL1
0x40,0x99,0x38,0xd5 = mrs	x0, PMSICR_EL1
0x60,0x99,0x38,0xd5 = mrs	x0, PMSIRR_EL1
0x80,0x99,0x38,0xd5 = mrs	x0, PMSFCR_EL1
0xa0,0x99,0x38,0xd5 = mrs	x0, PMSEVFR_EL1
0xc0,0x99,0x38,0xd5 = mrs	x0, PMSLATFR_EL1
0xe0,0x99,0x38,0xd5 = mrs	x0, PMSIDR_EL1