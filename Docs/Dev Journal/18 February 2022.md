## Split Sequence File

Split the `N8-sequences.txt` file into 100-line files:

```bash
$ split  -l 100  --numeric-suffixes=0  --suffix-length=3  --additional-suffix=.txt  N8-sequences.txt  boards-
```

### Check result

```bash
$ head -2 boards-000.txt
225777645468853638316485548886687777
225777645468853638316665584888487777

$ tail -2 boards-186.txt
888844888665736873577216655347772654
888844888665763873577216655347772654
```
