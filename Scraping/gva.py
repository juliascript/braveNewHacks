import requests, unicodedata, json
from bs4 import BeautifulSoup


class Incident(dict):

	def __init__(self, iterable=None):
		super(Incident, self).__init__()
		if iterable:
			self.update(iterable)

	def update(self, iterable):

		arrayOfKeys = ['date', 'state', 'city', 'address', 'numKilled', 'numInjured', 'links']

		for i in range(len(iterable)): 

			if arrayOfKeys[i] == 'links':
				links = iterable[i].find_all('a')
				value = {'incident': links[0], 'source': links[1]}
			else:
				value = iterable[i].text
			
			key = "%s" % arrayOfKeys[i]
			self[key] = value


def make_request(day):
	url = "http://www.gunviolencearchive.org/query/f2392d4e-8219-4ade-8711-0de9f34567a2"

	req = requests.get(url)

	data = req.text

	soup = BeautifulSoup(data, 'lxml')

	f = open('gva.html', 'w')
	f.write("%s" % soup)

	results = soup.select("tr")

	resultList = []


	for result in results:
		resultComponents = []
		tdTags = result.find_all('td')
		for td in tdTags:
			resultComponents.append(td)
			incident = Incident(resultComponents)
			resultList.append(incident)

	# for result in resultList:
	# 	print result, '\n\n'

	return resultList

if __name__ == "__main__":
	results = make_request("11/19/2015")
	for result in results:
		print result



