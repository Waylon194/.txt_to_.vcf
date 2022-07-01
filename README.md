# .txt_to_.vcf
Place your data into input.txt (inside the Example folder) like this:
Example One,+31 6 12345678
Example Two,+31 6 12345678

Run Text_to_Vcf_generator.exe and your output(.vcf) will be generated.

I used the following template:
BEGIN:VCARD
VERSION:4.0
FN:
TEL; WORK; VOICE:
END:VCARD

Which is a bare minimum, but you can edit it to your needs (files must be placed inside .txt_to_.vcf\Text_to_Vcf_generator\bin\Debug).