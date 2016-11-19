import requests, unicodedata, json
from bs4 import BeautifulSoup


class Incident(dict):

	def __init__(self, iterable=None):
		super(Incident, self).__init__()
		if iterable:
			self.update(iterable)

	def update(self, iterable):
		for item in iterable: 
			self['%s' % item] = item


# November 19th, 2015 , firearm deaths
url = "http://www.gunviolencearchive.org/query/f2392d4e-8219-4ade-8711-0de9f34567a2"

req = requests.get(url)

data = req.text

soup = BeautifulSoup(data, 'lxml')

f = open('gva.html', 'w')
f.write("%s" % soup)

results = soup.select("tr")

resultList = []
resultComponents = []

for result in results:
	# print result, '\n\n'
	# jsonResult = json.dumps(result, indent=2)
	allTDtags = result.find_all('td'), '\n\n'
	# print '---', allTDtags, '---'
	for td in allTDtags:
		for i in range(len(td)):
			resultComponents.append(td[i])
		incident = Incident(resultComponents)
		resultList.append(incident)
		print '--'

for result in resultList:
	print result, '\n\n'








